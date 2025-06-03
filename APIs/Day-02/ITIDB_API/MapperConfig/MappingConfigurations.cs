using AutoMapper;
using ITIDB_API.DTOs.DepartmentDTOs;
using ITIDB_API.DTOs.StudentDTOs;
using ITIDB_API.Models;

namespace ITIDB_API.MapperConfig
{
    public class MappingConfigurations : Profile
    {
        public MappingConfigurations()
        {
            CreateMap<Student, StudentDTO>()
                .AfterMap((st, stDTO) =>
                {
                    stDTO.Fname = st.St_Fname;
                    stDTO.Lname = st.St_Lname;
                    stDTO.Address = st.St_Address;
                    stDTO.Age = st.St_Age;
                })
                .ReverseMap()
                .AfterMap((stDTO, st) =>
                {
                    st.St_Fname = stDTO.Fname;
                    st.St_Lname = stDTO.Lname;
                    st.St_Address = stDTO.Address;
                    st.St_Age = stDTO.Age;
                });

            CreateMap<Student, DisplayStudentDTO>()
                .IncludeBase<Student, StudentDTO>()
                .AfterMap((st, stDTO) =>
                {
                    stDTO.Id = st.St_Id;
                    stDTO.Dept_Name = st.Dept?.Dept_Name;
                    stDTO.Super_Name = st.St_superNavigation != null
                        ? $"{st.St_superNavigation.St_Fname ?? ""} {st.St_superNavigation.St_Lname ?? ""}".Trim()
                        : null;
                });

            CreateMap<Student, AddStudentDTO>()
                .IncludeBase<Student, StudentDTO>()
                .AfterMap((st, stDTO) =>
                {
                    stDTO.Super_Id = st.St_super;
                })
                .ReverseMap()
                .IncludeBase<StudentDTO, Student>()
                .AfterMap((stDTO, st) =>
                {
                    st.St_super = stDTO.Super_Id;
                });

            CreateMap<Department, DisplayDepartmentDTO>()
                .AfterMap((dept, deptDTO) =>
                {
                    deptDTO.Manager_Name = dept.Dept_ManagerNavigation?.Ins_Name;
                    deptDTO.StCount = dept.Students.Count();
                });

            CreateMap<Department, AddDepartmentDTO>().ReverseMap();
        }
    }
}
