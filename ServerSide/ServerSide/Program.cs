using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.IO;
using System.Data;
using DAL.Operations;
using DAL.Entitities;
using System.Runtime.Serialization.Json;


namespace ServerSide
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpListener server = new TcpListener(8000);
            server.Start();
            Console.WriteLine("Server started..");
            Socket acceptclient = server.AcceptSocket();

            if (acceptclient.Connected)
            {
                NetworkStream ns = new NetworkStream(acceptclient);
                StreamWriter sw = new StreamWriter(ns);
                StreamReader sr = new StreamReader(ns);
                sw.AutoFlush = true;
                OEmployees empOps = new OEmployees();
                EEmployees emp = new EEmployees();

                DataTable dt = empOps.SelectAll();
                dt.TableName = "employees";
                String json = Serialize(dt);
                sw.WriteLine(json);

                while (true)
                {
                    emp = Deserialize(sr.ReadLine());

                    switch (emp.Option)
                    {
                        case "Insert":
                            empOps.Insert(emp);
                            break;
                        case "Show":
                            dt = empOps.SelectAll();
                            dt.TableName = "employees";
                            json = Serialize(dt);
                            sw.WriteLine(json);
                            break;
                        case "update":
                            empOps.Update(emp, emp.Emp_Id);
                            dt = empOps.SelectAll();
                            dt.TableName = "employees";
                            json = Serialize(dt);
                            sw.WriteLine(json);
                            break;
                        case "delete":
                            empOps.Delete(emp, emp.Emp_Id);
                            dt = empOps.SelectAll();
                            dt.TableName = "employees";
                            json = Serialize(dt);
                            sw.WriteLine(json);
                            break;
                    }
                }



                sw.Flush();
                sw.Close();
                ns.Close();

            }

            acceptclient.Close();

        }

        private static EEmployees Deserialize(string json)
        {


            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(json));
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(EEmployees));           
            return ser.ReadObject(ms) as EEmployees;
            
            
        }

        private static string Serialize(DataTable dt)
        {
            MemoryStream ms = new MemoryStream();
            DataContractJsonSerializer ser = new DataContractJsonSerializer(dt.GetType());
            ser.WriteObject(ms, dt);
            byte[] json = ms.ToArray();
            return Encoding.UTF8.GetString(json);

        }
    }
}
