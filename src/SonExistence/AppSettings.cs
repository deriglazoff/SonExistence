using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace SonExistence
{
    public class AppSettings
    {
        /// <summary>
        /// Подключение к RabbitMQ
        /// amqp://[username:password@]host1[:port1]/[vhost]
        /// </summary>
        public string ApiUrl { get; set; }

        /// <summary>
        /// Строки подключения
        /// </summary>
        public ConnectionStrings ConnectionStrings { get; set; }


    }
    public class ConnectionStrings
    {
        /// <summary>
        /// Подключение к RabbitMQ
        /// amqp://[username:password@]host1[:port1]/[vhost]
        /// </summary>
        public string RabbitConnection { get; set; }
        /// <summary>
        /// Подключение к Postgre
        /// </summary>
        public string PgSqlConnection { get; set; }

        /// <summary>
        /// Подключение к MS SQL
        /// </summary>
        public string MsSqlConnection { get; set; }
    }

}
