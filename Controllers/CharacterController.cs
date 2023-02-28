using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_RPG.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private static List<Character> characters = new List<Character>{
            new Character(),
            new Character{Id = 7, Name = "Sam"},
            new Character
                {
                    Id = 1,
                    Name = "Gandalf",
                    HitPoints = 150,
                    Strenght = 8,
                    Defense = 12,
                    Intelligence = 20,
                    Class = RpgClass.Mage
                },
                new Character
                {
                    Id = 2,
                    Name = "Aragorn",
                    HitPoints = 120,
                    Strenght = 15,
                    Defense = 15,
                    Intelligence = 12,
                    Class = RpgClass.Warrior
                },
                new Character{
                    Id = 3,
                    Name = "Legolas",
                    HitPoints = 110,
                    Strenght = 12,
                    Defense = 10,
                    Intelligence = 14,
                    Class = RpgClass.Knight
                },new Character
                {
                    Id = 4,
                    Name = "Gimli",
                    HitPoints = 130,
                    Strenght = 18,
                    Defense = 14,
                    Intelligence = 8,
                    Class = RpgClass.Knight
                },
                new Character
                {
                    Id = 5,
                    Name = "Gollum",
                    HitPoints = 60,
                    Strenght = 4,
                    Defense = 6,
                    Intelligence = 18,
                    Class = RpgClass.Assassin
                },
                new Character
                {
                    Id = 6,
                    Name = "Boromir",
                    HitPoints = 130,
                    Strenght = 18,
                    Defense = 12,
                    Intelligence = 10,
                    Class = RpgClass.Warrior
                }
        };
        [HttpGet("GetAll")]
        public ActionResult<List<Character>> Get()
        {
            return Ok(characters);
        }
        [HttpGet("{id}")]
        public ActionResult<Character> GetSingle(int id){
            return Ok(characters.FirstOrDefault(c=> c.Id == id));
        }
    }
}