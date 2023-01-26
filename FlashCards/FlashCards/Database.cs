using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards
{
    public class Database
    {
        public class FlashCard
        {
            // The DTO?
            public string Id { get; set; }
            public string Challenge { get; set; }
            public string Answer { get; set; }
        }

        public class FlashCardDisplayFormat
        {
            public string Challenge { get; set; }
            public string Answer { get; set; }
        }

        public class FlashCardStack
        {
            public string Id { get; set; }
            public string StackName { get; set; }
            public List<FlashCard> Cards { get; set; }
           
        }
        public static FlashCard GetFlashCard()
        {
            // The method to set the DTO?
            FlashCard thisFlashCard = new()
            {
               
            };


            return thisFlashCard;
        }

    }

    


}
