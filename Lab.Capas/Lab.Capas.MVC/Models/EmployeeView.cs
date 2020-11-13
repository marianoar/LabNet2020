using Errores;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace Lab.Capas.MVC.Models
{
    public class EmployeeView
    {
        [Required(ErrorMessage = "Si es un nuevo empleado ingrese 0.")]
        public int EmployeeId { get; set; }
        
        [Required (ErrorMessage ="Campo obligatorio")]
        [StringLength(20, ErrorMessage = "El Apellido debe tener entre 2 y 20 caracteres", MinimumLength = 2)]
        [NameValitation(ErrorMessage ="Este campo solo acepta letras")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [StringLength(20, ErrorMessage = "El Nombre debe tener entre 2 y 20 caracteres", MinimumLength = 2)]
        [NameValitation(ErrorMessage = "Este campo solo acepta letras")]
        public string FirstName { get; set; }

        public string Title { get; set; }

        [StringLength(20, ErrorMessage = "Address no puede ser > 20 caracteres")]
        public string Address { get; set; }

        [CityValitation (ErrorMessage ="Ciudades válidas: CABA o Rosario")]
        public string City { get; set; }

        [Required(ErrorMessage ="Campo obligatorio")]
        [EmailAddress(ErrorMessage ="Debe ingresar un correo válido")]
        public string EMail { get; set; }
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class CityValitation : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            try
            {
                switch (value)
                {
                    case "CABA":
                        return true;
                    case "Rosario":
                        return true;
                    default:
                        return false;
                }
            }
            catch (Exception ex)
            {
                throw new SaveLogsException("Error en ValitationAtribute City", ex);
            }
        }
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class NameValitation : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            try
            {
                if (value != null)
                {
                    string aux = value.ToString();
                    //string pattern = @"(\d+)";
                    string pattern = @"^[a-zA-Z ]*$";

                    Match match = Regex.Match(aux, pattern);
                    if (match.Success)
                    {
                        return true;
                    }
                }
                    return false;
            }
            catch (Exception ex)
            {
                throw new SaveLogsException("Error en ValitationAtribute Name", ex);
            }
        }
    }
}