using WebApplication2.DTOs;
using WebApplication2.Models;

namespace WebApplication2.Interfaces
{
    public interface IUserService
    {
        Task<List<UserDto>> GetAll();
        Task<UserDto?> GetById(int id);
        Task<UserDto> Create(CreateUserDto user);
        Task<bool> Update(int id, UpdateUserDto updatedUser);
        Task<bool> Delete(int id);
        Task<User> Login(LoginDTO login);
    }
}
