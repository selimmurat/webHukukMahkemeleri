using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class EmployeeUnitRoleDetailDTO
    {
        #region employee  // personel tablosu
        public int employeeId { get; set; }
        public string TC_KimlikNo { get; set; }
        public string sicil_no { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        #endregion

        #region Unit   // birim tablosu
        public int UnitId { get; set; }
        public int unit_code { get; set; }
        public string UnitName { get; set; }
        #endregion

        #region UnitArea // Birim Alanı tablosu
        public int unit_area_id { get; set; }
        public string unit_area_name { get; set; }
        #endregion

        #region UnitType // Birim türü tablosu
        public int unit_type_id { get; set; }
        public string unit_type_name { get; set; }
        #endregion

        #region City // Şehirler tablosu (birim hangi şehirde olduğu bilgisi için)
        public int city_id { get; set; }
        public string city_name { get; set; }
        #endregion

        #region Role  // Rol tablosu  ( personele verilen rolü ismini çekmek için)
        public int role_id { get; set; }
        public string role_name { get; set; }
        #endregion

        #region District // ilçe tablosu
        public string district_name { get; set; }
        #endregion




    }
}
