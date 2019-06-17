using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    //Класс, который определяет очередного подключенного клиента
    public class Client
    {
        public string Id;//идентификатор
        NetworkStream Stream;//поток клиента
        private TcpClient client;//объект клиент
        private Server server;//Объект сервера

        //конструктор, который инициализирует клиента и сервер
        public Client(TcpClient tcpClient, Server serverObject)
        {
            client = tcpClient;
            server = serverObject;
        }

        //прослушивание входящих данных
        public void Process()
        {
            try
            {
                Stream = client.GetStream();//получаем поток

                //запускаем бесконечный цикл прослушивания
                while (true)
                {
                    try
                    {
                        string connection_msg = String.Empty;//обнуляем строку с данными

                        byte[] data = new byte[100];//готовим буффер, куда будут загружаться байты
                        StringBuilder builder = new StringBuilder();//билдер, для создания полноценной строки из байт
                        int bytes = 0;//переменна для определения длины доступных для чтения байт
                        
                        //старт чтения данных, даже если их и нет они не считаются, т.к. для чтения задана длина в 0 байт
                        do
                        {
                            bytes = Stream.Read(data, 0, data.Length);//получаем кол-во считанных байт, и одновеременно считываем байты в буффер
                            builder.Append(Encoding.Unicode.GetString(data, 0, bytes));//присоединяем полученные данные к билдеру
                        } while (Stream.DataAvailable);//цикл работает, пока в потоке есть данные

                        connection_msg = builder.ToString();//преобразовавываеем из билдера в полноценную строку

                        //если строка не пустая, то обрабатываем сообщение
                        if (!String.IsNullOrEmpty(connection_msg))
                        {
                            ExecuteMessage(connection_msg);
                        }
                    }
                    catch
                    {
                        break;
                    }
                }
            }
            finally
            {
                Close();//если мы вышли из цикла прослушивания сообщений, то обрубаем соединение
            }
        }

        //обработчик сообщения
        private void ExecuteMessage(string message)
        {
            //команда имеет вид имя-данные, но данные могут отсутствовать

            string text = String.Empty;//имя
            string data = String.Empty;//данных

            //если в команде есть разделитель "-", то первый разделитель отделяет имя команды от данных
            if (message.IndexOf("-") > -1)
            {
                text = message.Substring(0, message.IndexOf("-"));//получаем имя команды
                data = message.Substring(message.IndexOf("-") + 1);//получаем данные
            }
            else//иначе, сообщение и есть команда
            {
                text = message;
            }

            //обрабатываем полученную команду

            if (text == "Result")//команда которая записывает результат игры(счет) в бд
            {
                FileStream aFile;
                StreamWriter sw;
                aFile = new FileStream(server.database_name, FileMode.Append, FileAccess.Write);//инициализируем файл, для записи в конец файла
                StreamWriter writer = new StreamWriter(aFile);//инициализируем стрим райтер этим файлом
                writer.WriteLine("\"" + 1 + "\"" + "," + "\"" + data + "\"");//записываем данные, полученные от клиента в специальном формате
                writer.Close();//закрываем райтер
                aFile.Close();//закрываем файл
            }
            else if (text == "LoadResult")//команда, которая отправляет клиенту результаты игр других
            {
                OleDbConnection connectionDB = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" +
                                                                   AppDomain.CurrentDomain.BaseDirectory +
                                                                   ";Extended Properties=text");//инициируем соединение
                string Select1 = "SELECT * FROM [" + server.database_name + "]";//записываем команду для выборкиданных
                OleDbCommand comand1 = new OleDbCommand(Select1, connectionDB);//соединяем команду и соединение
                OleDbDataAdapter adapter1 = new OleDbDataAdapter(comand1);//создаем адаптер, для заполнения дата сета
                DataSet AllTables = new DataSet();//создаем дата сет
                connectionDB.Open();//выполняем соединение
                adapter1.Fill(AllTables);//загружаем в дата сет данные, полученные командой
                connectionDB.Close();//закрываем соединение

                //далее формируется ответ
                string msg_answer = String.Empty;//создаем строку для ответа

                if (AllTables.Tables[0].Rows.Count > 0)//если какие-либо данные были загружены из базы, то обрабатываем их
                {
                    int[] result = new int[AllTables.Tables[0].Rows.Count];//создаем массив с результатами(результаты - числа, равные кол-ву набранных очков в игер)

                    for (int i = 0; i < AllTables.Tables[0].Rows.Count; i++)//данные, которые хранятся в колонке RESULT из дата сета в массив
                    {
                        result[i] = int.Parse(AllTables.Tables[0].Rows[i]["RESULT"].ToString());
                    }

                    Array.Sort(result);//сортируем массив

                    foreach (var i in result)//записываем отсортированный массив в строку, по-убыванию
                    {
                        msg_answer = i + "|"+ msg_answer;
                    }

                    msg_answer = msg_answer.Substring(0, msg_answer.Length - 1);//обрезаем лишнее
                }
                else//если данные не были загружены, то строка должна быть пустой
                {
                    msg_answer = String.Empty;
                }

                SendMessage(msg_answer);//отправляем ответ
            }
        }

        //процедура отправки ответа
        public void SendMessage(string message)
        {
            byte[] data = Encoding.Unicode.GetBytes(message);//переводим строку в байты
            Stream.Write(data, 0, data.Length);//записываем байты в поток
        }

        //процедура закрытия соединения
        public void Close()
        {
            if (Stream != null)
                Stream.Close();
            if (client != null)
                client.Close();
        }
    }
}
