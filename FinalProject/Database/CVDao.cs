using FinalProject.Objects;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Database
{
    internal class CVDao
    {
        DBConnections db = new DBConnections();

/*        public void Them(CV cv)
        {
<<<<<<< HEAD
            string SQL = string.Format("INSERT INTO CVInformation(ID, FullName, PositionApplied, Gender, DateOfBirth, PhoneNumber, Email, Address,ObjectiveDescription, SkillName, InterestName, ReferenceInformation, EducationDescription,ExperienceDescription, ActivityDescription, CertificationName, AwardName, AdditionalInfoDescription) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}')", cv.FullName, cv.PositionApplied, cv.Gender, cv.DateOfBirth, cv.PhoneNumber, cv.Email, cv.Address, cv.ObjectiveDescription, cv.SkillName, cv.InterestName, cv.ReferenceInformation, cv.EducationDescription, cv.ExperienceDescription, cv.ActivityDescription, cv.CertificationName, cv.AwardName, cv.AdditionalInfoDescription);
=======
            string SQL = string.Format("INSERT INTO CVInformation(FullName, PositionApplied, Gender, DateOfBirth, PhoneNumber, Email, Address,ObjectiveDescription, SkillName, InterestName, ReferenceInformation, EducationDescription,ExperienceDescription, ActivityDescription, CertificationName, AwardName, AdditionalInfoDescription) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}')",cv.FullName, cv.PositionApplied, cv.Gender, cv.DateOfBirth, cv.PhoneNumber, cv.Email, cv.Address, cv.ObjectiveDescription, cv.SkillName, cv.InterestName, cv.ReferenceInformation, cv.EducationDescription, cv.ExperienceDescription, cv.ActivityDescription, cv.CertificationName, cv.AwardName, cv.AdditionalInfoDescription);
>>>>>>> 3a58fd969bb9a8d8595218a748af6a629accf9fa
            db.ThucThi(SQL);
        }*/
    }
}
