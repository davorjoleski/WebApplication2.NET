using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using WebApplication2.Data;
using WebApplication2.DTOs;
using WebApplication2.Interfaces;
using WebApplication2.Models;
using BC = BCrypt.Net.BCrypt;

namespace WebApplication2.Services
{

    public class UserService : IUserService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public UserService(AppDbContext context, IMapper mapper)
        {

            _mapper = mapper;
            _context = context;
        }

        public async Task<List<UserDto>> GetAll()
        {

            var users = await _context.Users.ToListAsync();
            if (users == null) throw new Exception("Test exception");

            return _mapper.Map<List<UserDto>>(users);

        }

        public async Task<UserDto> Create(CreateUserDto dto)
        {
            var user = _mapper.Map<User>(dto);

            user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(dto.Password);

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return _mapper.Map<UserDto>(user);
        }

        public async Task<bool> Delete(int id)
        {
            var user = await _context.Users.FindAsync(id);

            if (user == null)
                throw new Exception("Delete Exception null");


            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return true;
        }



      

        public async Task<UserDto?> GetById(int id)
        {
            var user = await _context.Users.FindAsync(id);
            return _mapper.Map<UserDto>(user);
        }

        public async Task<bool> Update(int id, UpdateUserDto dto)
        {
            var user = await _context.Users.FindAsync(id);

            if (user == null)
                return false;

            _mapper.Map(dto, user);

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<User?> Login(LoginDTO dto)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Email == dto.Email);

            if (user == null)
                return null;

            var isValid = BCrypt.Net.BCrypt.Verify(dto.Password, user.PasswordHash);

            Console.WriteLine(isValid);
            if (!isValid)
                return null;

            return user;
        }


    }
}
