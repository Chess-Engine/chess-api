using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using chess.business;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace chess_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PieceMovementController : ControllerBase
    {


        [HttpGet]
        public List<bool> Get()
        {

            Piece[,] b = new Piece[8, 8];
            
            b[0, 2] = new Piece(Sort.Pawn, Color.Black);
            b[2, 2] = new Piece(Sort.Pawn, Color.White);


            bool[,] result = MovementChecker.CheckWhitePawnMoves(1, 1, b);

            var lst = result.Cast<bool>().ToList();


            return lst;
        }




    }
}
