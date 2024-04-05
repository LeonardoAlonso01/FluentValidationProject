namespace FluentValidation.API.Application.InputModels
{
    public class CreatePersonInputModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
    }
}
