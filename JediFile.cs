using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api
{
    public class JediFile
    {
        private List<Jedi> jedis;

        public JediFile(List<Jedi> jedis){
            this.jedis = jedis;
        }

        public void GetAllJedi(){
            StreamReader inFile = new StreamReader("jediData.txt");
            string line = inFile.ReadLine();
            while(line != null){
                string[] temp = line.Split('#');
                if (temp.Length == 11 && int.TryParse(temp[0], out int jediId)) {
                    jedis.Add(new Jedi(){
                        JediId = jediId, 
                        Name = temp[1], 
                        LightsaberColor = temp[2], 
                        Homeworld = temp[3], 
                        Born = temp[4], 
                        Gender = temp[5], 
                        Rank = temp[6],
                        NickName = temp[7], 
                        Master = temp[8], 
                        Padawan = temp[9],
                        CharacterURL = temp[10]
                    });
                } else {
                    Console.WriteLine($"Skipping invalid line: {line}");
                }
                line = inFile.ReadLine();
            }
            inFile.Close();
        }
    }
}