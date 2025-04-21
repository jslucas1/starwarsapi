using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api
{
    public class Jedi
    {
        public int JediId {get; set;}
        public string Name {get; set;}
        public string LightsaberColor {get; set;}
        public string Homeworld {get; set;}
        public string Born {get; set;}
        public string Gender {get; set;}
        public string Rank {get; set;}
        public string NickName {get; set;}
        public string Master {get; set;}
        public string Padawan {get; set;}
        public string CharacterURL {get; set;}
        public  string ToFile(){
            return $"{JediId}#{Name}#{LightsaberColor}#{Homeworld}#{Born}#{Gender}#{Rank}#{NickName}#{Master}#{Padawan}#{CharacterURL}";
        }
        
    }
}