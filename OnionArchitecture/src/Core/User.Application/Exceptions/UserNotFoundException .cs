using System;
using System.Collections.Generic;
using System.Text;
using User.Domain.Entities;

namespace User.Application.Exceptions
{
    public sealed class UserNotFoundException : CustomException
    {
        public UserNotFoundException(UserProfile userProfile ) : base( $"{userProfile} kullanıcı bulunamadı.")
        {

        }
    }
}
