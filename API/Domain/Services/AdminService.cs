using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using minimal_api.Domain.DTOs;
using minimal_api.Domain.Entities;
using minimal_api.Domain.Interfaces;
using minimal_api.infrastructure.DB;

namespace minimal_api.Domain.Services
{
    public class AdminService : IAdminService
    {
        public readonly MinimalApiContext _context;
        public AdminService(MinimalApiContext context)
        {
            _context = context;
        }

        public Admin? BuscaPorId(int id)
        {
            return _context.Admins.Where(admin => admin.Id == id).FirstOrDefault();
        }

        public Admin Incluir(Admin admin)
        {
            _context.Admins.Add(admin);
            _context.SaveChanges();
            return admin;
        }

        public Admin? Login(LoginDTO loginDTO)
        {
            var admin = _context.Admins.Where(adm => adm.Email == loginDTO.Email && adm.Senha == loginDTO.Senha).FirstOrDefault();
            return admin;
        }

        public List<Admin> Todos(int? pagina)
        {
            var query = _context.Admins.AsQueryable();

            int itensPorPagina = 10;

            if (pagina != null)
                query = query.Skip(((int)pagina - 1) * itensPorPagina).Take(itensPorPagina);

            return query.ToList();
        }
    }
}