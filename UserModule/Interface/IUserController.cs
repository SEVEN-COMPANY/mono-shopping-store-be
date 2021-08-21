
using store.UserModule.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace store.UserModule.Interface
{
    public interface IUserController
    {

        public ObjectResult updateUser(UpdateUserDto body);
        public ObjectResult getUser();

        public ObjectResult updateAvatar(IFormFile file);
    }
}
