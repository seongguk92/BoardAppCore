using BoardAppCore.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoardAppCore.Models
{
    public class COpinitonRepository : IOpinitonRepository
    {
        private readonly ApplicationDbContext _context;

        public COpinitonRepository(ApplicationDbContext context)
        {
            this._context = context;
        }

        //의견 추가
        public async Task<COpinion> AddOpinion(COpinion cOpinion)
        {
            _context.ETC_BOARD.Add(cOpinion);
            await _context.SaveChangesAsync();
            return cOpinion;
        }

        //의견 가져오기
        public async Task<List<COpinion>> GetOpinions()
        {
            return await _context.ETC_BOARD.ToListAsync();
        }

        //의견 삭제
        public async Task DeleteOpinions(int board_id)
        {
            var opinion = await _context.ETC_BOARD.FindAsync(board_id);
            _context.Remove(opinion);
            await _context.SaveChangesAsync();
        }
    }
}
