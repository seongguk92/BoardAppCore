using BoardAppCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoardAppCore.Models
{
    interface IOpinitonRepository
    {
        //의견 추가
        Task<COpinion> AddOpinion(COpinion cOpinion);
        //의견 가져오기
        Task<List<COpinion>> GetOpinions();
        //의견 삭제
        Task DeleteOpinions(int board_id);
    }
}
