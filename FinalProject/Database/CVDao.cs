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

        public void Them(CV cv)
        {
            string SQL = string.Format("INSERT INTO CVInformation(FullName, PositionApplied, Gender, DateOfBirth, PhoneNumber, Email, Address,ObjectiveDescription, SkillName, InterestName, ReferenceInformation, EducationDescription,ExperienceDescription, ActivityDescription, CertificationName, AwardName, AdditionalInfoDescription) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}')",cv.FullName, cv.PositionApplied, cv.Gender, cv.DateOfBirth, cv.PhoneNumber, cv.Email, cv.Address, cv.ObjectiveDescription, cv.SkillName, cv.InterestName, cv.ReferenceInformation, cv.EducationDescription, cv.ExperienceDescription, cv.ActivityDescription, cv.CertificationName, cv.AwardName, cv.AdditionalInfoDescription);
            db.ThucThi(SQL);
        }
    }
}
