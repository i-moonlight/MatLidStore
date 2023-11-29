﻿using FluentValidation.Results;

namespace MLS.Application.Exceptions
{
    public class BadRequestException : Exception
    {
        public BadRequestException(string message) : base(message)
        {
        }

        public BadRequestException(string message, ValidationResult validationResult) : base(message)
        {
            ValidationErrors = new();
            foreach (var errors in validationResult.Errors)
            {
                ValidationErrors.Add(errors.ErrorMessage);
            }
        }

        private List<string> ValidationErrors { get; set; }
    }
}