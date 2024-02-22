using System.Net;

namespace SudaneseShop.API.Models
{
    public class ResponseDto
    {
        public object? Result { get; set; }
        public bool IsSuccess { get; set; } = true;
        public List<string> ErrorMessages { get; } = new List<string>();
        public HttpStatusCode StatusCode { get; set; }

        private ResponseDto SetStatusCode(HttpStatusCode statusCode)
        {
            StatusCode = statusCode;
            IsSuccess = false;
            return this;
        }

        public ResponseDto BadRequest(params string[] errorMessages)
        {
            ErrorMessages.AddRange(errorMessages);
            return SetStatusCode(HttpStatusCode.BadRequest);
        }

        public ResponseDto Unauthorized(params string[] errorMessages)
        {
            ErrorMessages.AddRange(errorMessages);
            return SetStatusCode(HttpStatusCode.Unauthorized);
        }

        public ResponseDto Forbidden(params string[] errorMessages)
        {
            ErrorMessages.AddRange(errorMessages);
            return SetStatusCode(HttpStatusCode.Forbidden);
        }

        public ResponseDto NotFound(params string[] errorMessages)
        {
            ErrorMessages.AddRange(errorMessages);
            return SetStatusCode(HttpStatusCode.NotFound);
        }

        public ResponseDto Conflict(params string[] errorMessages)
        {
            ErrorMessages.AddRange(errorMessages);
            return SetStatusCode(HttpStatusCode.Conflict);
        }

        public ResponseDto InternalServerError(params string[] errorMessages)
        {
            ErrorMessages.AddRange(errorMessages);
            return SetStatusCode(HttpStatusCode.InternalServerError);
        }
    }
}
