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
            while(line!= null){
                string[] temp = line.Split('#');
                jedis.Add(new Jedi(){JediId = int.Parse(temp[0]), 
                                    Name = temp[1], 
                                    LightsaberColor=temp[2], 
                                    Homeworld=temp[3], 
                                    Age = int.Parse(temp[4]), 
                                    Gender=temp[5], 
                                    Rank = temp[6],
                                    NickName=temp[7], 
                                    Master=temp[8], 
                                    Padawan=temp[9]});
                line = inFile.ReadLine();
            }
            inFile.Close();
        }
    }
}