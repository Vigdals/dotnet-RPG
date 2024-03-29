global using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace dotnet_RPG.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
        private static List<Character> characters = new List<Character>{
            //Creating a lot of characters here for fun tho
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

        private readonly IMapper _mapper;
        public CharacterService(IMapper mapper)
        {
            _mapper = mapper;
        }
        
        public async Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter)
        {
            var serviceResponse = new ServiceResponse<List<GetCharacterDto>>();
            characters.Add(_mapper.Map<Character>(newCharacter));
            serviceResponse.Data = characters.Select(c => _mapper.Map<GetCharacterDto>(c)).ToList();
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters()
        {
            var serviceResponse = new ServiceResponse<List<GetCharacterDto>>();
            serviceResponse.Data = characters.Select(c => _mapper.Map<GetCharacterDto>(c)).ToList();
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id)
        {
            var serviceResponse = new ServiceResponse<GetCharacterDto>();
            var character = characters.FirstOrDefault(c=> c.Id == id);
            serviceResponse.Data = _mapper.Map<GetCharacterDto>(character);
            return serviceResponse;
        }
    }
}