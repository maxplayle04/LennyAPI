using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LennyAPI.Stuff
{
    public class LennyAction
    {
        
        public ELennyStatus Status { get; set; }

        public string Information { get; set; }

        public LennyAction(ELennyStatus statusIn, string informationIn = null)
        {
            this.Status = statusIn;
            this.Information = informationIn;

        }

        public void Perform()
        {
            switch (Status)
            {

                case ELennyStatus.Status_Bullying:
                    Console.WriteLine("Lenny is bullying " +  this.Information);
                    break;

                case ELennyStatus.Status_Custom:
                    Console.WriteLine("Lenny " + this.Information);
                    break;

                case ELennyStatus.Status_DMing_Megan:
                    Console.WriteLine("Lenny is DMing Megan about " + this.Information);
                    break;

                case ELennyStatus.Status_Sleeping:
                    Console.WriteLine("Lenny is sleeping with " + this.Information);
                    break;

                case ELennyStatus.Status_TalkingOnDiscordTo:
                    Console.WriteLine("Lenny is on Discord talking to " + this.Information);
                    break;

                case ELennyStatus.Status_Eating:
                    Console.WriteLine("Lenny is eating " + this.Information);
                    break;

                default:
                    throw new InvalidOperationException("Cannot resolve Lenny's action!");
            
            }
        }

    }
}
