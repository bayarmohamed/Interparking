using Interparking.DAL.Abstraction;
using Interparking.DAL.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace Interparking.WeppApp.Command
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, bool>
    {

        IUserRepository _userRepository;

        public CreateUserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        
       
        public Task<bool> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var userdto = new UserModel
            {
                email = request.email,
                name = request.name,
                password = request.password
            };

            _userRepository.AddUser(userdto);

            return Task.FromResult(true);
        }
    }
}