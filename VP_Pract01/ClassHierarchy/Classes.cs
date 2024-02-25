﻿namespace ClassesProject
{
    public class Department
    {
        private int department_id;
        private string department_name;

        public void insertDepartment() { }
        public void updateDepartment() { }
        public void deleteDepartment() { }
    }


    public class Report
    {
        private int Report_code;
        private DateTime Report_date;

        public void viewReports() { }
        public void createReports() { }
    }

    public class User
    {
        private int user_id;
        private int department_id;
        private string user_username;
        private string user_password;
        private string user_name;
        private Gender user_gender;
        private string user_email;
        private RoleUser user_role;

        public void userLogin() { }
        public void addProposal() { }
        public void viewProposal() { }
        public void confirmProposal() { }
        public void createReports() { }
        public void viewReports() { }
        public void updateDepartment() { }
    }

    public class Login
    {
        private string username;
        private string password;

        public void loginStatus() { }
    }

    public class Proposal
    {
        private string proposal_code;
        private string proposal_title;
        private string proposal_text;
        private DateTime proposal_date;
        private StatusProposal  Proposal_status = StatusProposal.Waiting;

        public void viewProposal() { }
        public void viewStatus() { }
        public void updateProposal() { }
        public void deleteProposal() { }
        public void archiveProposal() { }
        public void viewApplicant() { }
    }

    public class Applicant
    {
        private int Applicant_id;
        private string Applicant_name;
        private string Applicant_job;
        private string Applicant_addres;
        private Gender Applicant_gender;
        private char[] Applicant_tel = new char[16];
    }

    enum RoleUser
    {
        PublicRelation,
        Division,
        Manager
    }

    enum Gender
    {
        Male,
        Female
    }
    enum StatusProposal
    {
        Waiting,
        Rejected,
        Accepted
    }
}