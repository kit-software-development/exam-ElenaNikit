using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    public class Net
    {
        private string host = "127.0.0.1";//адрес удаленного сервера, в данном случае локальный сервер
        private int port = 6589;//порт удаленного сервера
        private TcpClient client;//объект клиента
        private NetworkStream stream;//объект потока
        private string message;//сообщение, которое будет приходить от сервера
        public bool isConnect = false;//флаг, который указывает было ли установлено подключение

        GameForm gameForm;//объект формы

        //конструктор
        public Net(GameForm obj)
        {
            gameForm = obj;//инициализация объекта
        }

        //запуск соединения с сервером
        public void Start()
        {
            //если соединения нет
            if (!isConnect)
            {
                client = new TcpClient();//инициализация клиента
                try
                {
                    client.Connect(host, port);//устанавливаем соединение
                    stream = client.GetStream();//получаем поток

                    isConnect = true;//меняем флаг
                    Task.Run((Action)GetMessage);//запускаем обработчик ответов от сервера в отдельном потоке
                }
                catch
                {
                }
            }
        }

        //процедура отправки сообщения серверу
        public void SendMessage(string msg)
        {
            byte[] data = Encoding.Unicode.GetBytes(msg);//переводим строку в байты
            stream.Write(data, 0, data.Length);//записываем байты в поток
        }

        //процедура обработки ответа от сервера
        private void GetMessage()
        {
            StringBuilder builder = new StringBuilder();//создаем билдер, для работы с текстом
            while (true)//бесконечный цикл прослушивания ответа от сервера
            {
                try
                {
                    byte[] data = new byte[64];//создаем буффер для загрузки байтов
                    builder = new StringBuilder();//обнуляем билдер
                    int bytes = 0;//обнуляем кол-во байт
                    //цикл чтения из потока
                    do
                    {
                        bytes = stream.Read(data, 0, data.Length);//читаем поток и одноверменно записываем, сколько байт прочитано
                        builder.Append(Encoding.Unicode.GetString(data, 0, bytes));//добавляем строку к билдеру
                    }
                    while (stream.DataAvailable);//цикл работает пока есть данные
                    message = builder.ToString();//преобразуем билдер в строку

                    //т.к. от сервера мы можем получить только один ответ, а именно, список результатов игр, то сразу обрабатываем одно сообщение
                    gameForm.LoadResult(message);
                    Thread.Sleep(10);//пауза в 10мс, для того, что сообщения не склеивались, а также снижалась нагрузка
                }
                catch
                {
                    Disconnect();//в случае проблем отключаем соединение
                }
            }
        }

        //Процедура откючения соединия
        public void Disconnect()
        {
            if (isConnect)//если подключение есть, то отключаемся
            {
                stream?.Close();
                client?.Close();
                isConnect = false;
            }
        }
    }
}

