export class RegisterJobSeekerDTO
{
     jobSeekerName : string;
     userName : string;
     email : string;
     password : string;
     confirmPassword : string;
     gender : string;
     contactPhone : string;
     address : string | null;
     description : string | null;
     dateOfBirth : Date;
     qualification : string | null;
     specialization : string | null;
     institute : string | null;
     year : number | null;
     cgpa : number | null;
     companyName : string | null;
     position : string | null;
     responsibilities : string | null;
     startDate : Date | null;
     endDate : Date | null;
}