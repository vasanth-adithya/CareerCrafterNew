export class JobSeeker {
  jobSeekerId: number;
  jobSeekerName: string;
  userName: string;
  email: string;
  password: string;
  gender: string;
  contactPhone: string;
  address: string | null;
  description: string | null;
  dateOfBirth: Date;
  qualification: string | null;
  specialization: string | null;
  institute: string | null;
  year: number | null;
  cgpa: number | null;
  companyName: string | null;
  position: string | null;
  responsibilities: string | null;
  startDate: Date | null;
  endDate: Date | null;
  // expiresIn: Date;
  role?: string;
  token?: string;
  resetPasswordExpires?: Date | null;
  

  constructor(
      jobSeekerId: number,
      jobSeekerName: string,
      userName: string,
      email: string,
      password: string,
      gender: string,
      contactPhone: string,
      address: string,
      description: string,
      dateOfBirth: Date,
      qualification: string,
      specialization: string,
      institute: string,
      year: number,
      cgpa: number,
      companyName: string,
      position: string,
      responsibilities: string,
      startDate: Date,
      endDate: Date,
      role?: string,
      token?: string,
      resetPasswordExpires?: Date
  ) {
      this.jobSeekerId = jobSeekerId;
      this.jobSeekerName = jobSeekerName;
      this.userName = userName;
      this.email = email;
      this.password = password;
      this.gender = gender;
      this.contactPhone = contactPhone;
      this.address = address;
      this.description = description;
      this.dateOfBirth = dateOfBirth;
      this.qualification = qualification;
      this.specialization = specialization;
      this.institute = institute;
      this.year = year;
      this.cgpa = cgpa;
      this.companyName = companyName;
      this.position = position;
      this.responsibilities = responsibilities;
      this.startDate = startDate;
      this.endDate = endDate;
      // this.expiresIn = expiresIn;
      this.role = role;
      this.token = token;
      this.resetPasswordExpires = resetPasswordExpires;
      
  }
}
