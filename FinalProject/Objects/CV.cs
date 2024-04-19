using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Objects
{
    public class CV
    {
        string idCV;
        string id;
        string cVTitle;
        string careerGoals;
        string skill;
        string presenter;
        string experience;
        string activitie;
        string certificate;
        string awards;
        string addInformation;


        // Toàn bộ nội dung của CV tạm thời thu gọn thành description, sau này sẽ trả lại
        


        public CV() { }
        public CV(string idCV) 
        {
           IdCV = idCV;
        }
        public CV(string idCV, string id, string cVTitle, string careerGoals, string skill, string presenter, string experience, string activitie, string certificate, string awards, string addInformation)
        {
            IdCV = idCV;
            ID = id;
            CVTitle = cVTitle;
            CareerGoals = careerGoals;
            Skill = skill;
            Presenter = presenter;
            Experience = experience;
            Activitie = activitie;
            Certificate = certificate;
            Awards = awards;
            AddInformation = addInformation;
        }

        public string CareerGoals { get => careerGoals; set => careerGoals = value; }
        public string Skill { get => skill; set => skill = value; }
        public string Presenter { get => presenter; set => presenter = value; }
        public string Experience { get => experience; set => experience = value; }
     
        public string Certificate { get => certificate; set => certificate = value; }
        public string Awards { get => awards; set => awards = value; }
  
        
        public string Activitie { get => activitie; set => activitie = value; }
        public string AddInformation { get => addInformation; set => addInformation = value; }
        public string IdCV { get => idCV; set => idCV = value; }
        public string CVTitle { get => cVTitle; set => cVTitle = value; }
        public string ID { get => id; set => id = value; }
    }
}
