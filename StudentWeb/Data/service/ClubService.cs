using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWeb.Data.service
{

    public class ClubService
    {

        private readonly ApplicationDbContext _context;


        public ClubService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<model.Club>> GetClubs()
        {
            return await _context.Clubs.FromSqlRaw("SELECT * FROM dbo.fnGet_Clubs()").ToListAsync();
        }
        public async Task<List<model.ClubsByLeague>> GetClubsByLeagues()
        {
            return await _context.ClubsByLeagues.FromSqlRaw("SELECT * FROM dbo.fnGet_ClubsByLeague()").ToListAsync(); 
        }
        //public List<model.ClubsByLeague> FilterClubsByLeagues(List<model.ClubsByLeague> clubs, int YearEstablished)
        //{
        //    //_context.ClubsByLeagues.FromSqlRaw("SELECT * FROM dbo.fnGet_ClubsByLeague()").ToList().Where(i => i.YearEstablished >= YearEstablished).ToList();
        //    return clubs.Where(i => i.YearEstablished >= YearEstablished).ToList();

        //}

    }
}
