using System;

namespace peliculasAPI.Entidades
{
    internal class RequieredAttribute : Attribute
    {
        public string ErrorMessage { get; set; }
    }
}