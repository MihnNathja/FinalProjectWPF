using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Objects
{
    public class CV
    {
        int idCV;
        string careerGoals;
        string skill;
        string presenter;
        string experience;
        string activitie;
        string certificate;
        string award;
        string addInformation;


        // Toàn bộ nội dung của CV tạm thời thu gọn thành description, sau này sẽ trả lại
        


        public CV() { }
        public CV(string careerGoals) 
        {
            CareerGoals = careerGoals;
        }
        public CV(int idCV, string careerGoals, string skill, string presenter, string experience, string activitie, string certificate, string award, string addInformation)
        {
            IdCV = idCV;
            CareerGoals = careerGoals;
            Skill = skill;
            Presenter = presenter;
            Experience = experience;
            Activitie = activitie;
            Certificate = certificate;
            Award = award;
            AddInformation = addInformation;
            
        }

        public string CareerGoals { get => careerGoals; set => careerGoals = value; }
        public string Skill { get => skill; set => skill = value; }
        public string Presenter { get => presenter; set => presenter = value; }
        public string Experience { get => experience; set => experience = value; }
     
        public string Certificate { get => certificate; set => certificate = value; }
        public string Award { get => award; set => award = value; }
  
        
        public string Activitie { get => activitie; set => activitie = value; }
        public string AddInformation { get => addInformation; set => addInformation = value; }
        public int IdCV { get => idCV; set => idCV = value; }
    }
}
