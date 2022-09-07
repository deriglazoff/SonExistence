using SonExistence.Dto;
using SonExistence.Models;

namespace SonExistence.Interfaces
{
    public interface IRepository
    {
        /// <summary>
        /// Обработка сообщения
        /// </summary>
        /// <returns></returns>
        public Response Save(DocumentDto message);

    }
}