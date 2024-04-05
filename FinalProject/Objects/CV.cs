using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Objects
{
    public class CV
    {
        string fullName;
        string positionApplied;
        string gender;
        DateTime dateOfBirth;
        string phoneNumber;
        string email;
        string address;
        string objectiveDescription;
        string skillName;
        string interestName;
        string referenceInformation;
        string educationDescription;
        string experienceDescription;
        string activityDescription;
        string certificationName;
        string awardName;
        string additionalInfoDescription;

        public CV() { }

        public CV(string fullName, string positionApplied, string gender, DateTime dateOfBirth, string phoneNumber, string email, string address, string objectiveDescription, string skillName, string interestName, string referenceInformation, string educationDescription, string experienceDescription, string activityDescription, string certificationName, string awardName, string additionalInfoDescription)
        {
            FullName = fullName;
            PositionApplied = positionApplied;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
            Email = email;
            Address = address;
            ObjectiveDescription = objectiveDescription;
            SkillName = skillName;
            InterestName = interestName;
            ReferenceInformation = referenceInformation;
            EducationDescription = educationDescription;
            ExperienceDescription = experienceDescription;
            ActivityDescription = activityDescription;
            CertificationName = certificationName;
            AwardName = awardName;
            AdditionalInfoDescription = additionalInfoDescription;
            
        }

        public string FullName { get => fullName; set => fullName = value; }
        public string PositionApplied { get => positionApplied; set => positionApplied = value; }
        public string Gender { get => gender; set => gender = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Email { get => email; set => email = value; }
        public string Address { get => address; set => address = value; }
        public string ObjectiveDescription { get => objectiveDescription; set => objectiveDescription = value; }
        public string SkillName { get => skillName; set => skillName = value; }
        public string InterestName { get => interestName; set => interestName = value; }
        public string ReferenceInformation { get => referenceInformation; set => referenceInformation = value; }
        public string EducationDescription { get => educationDescription; set => educationDescription = value; }
        public string ExperienceDescription { get => experienceDescription; set => experienceDescription = value; }
        public string ActivityDescription { get => activityDescription; set => activityDescription = value; }
        public string CertificationName { get => certificationName; set => certificationName = value; }
        public string AwardName { get => awardName; set => awardName = value; }
        public string AdditionalInfoDescription { get => additionalInfoDescription; set => additionalInfoDescription = value; }
    }
}
