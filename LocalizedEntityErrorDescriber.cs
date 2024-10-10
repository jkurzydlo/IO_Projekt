using Microsoft.AspNetCore.Identity;

namespace ksiegarniaAp {
	public class LocalizedIdentityErrorDescriber : IdentityErrorDescriber {
		public override IdentityError DuplicateEmail(string email) {
			return new IdentityError
			{
				Code = nameof(DuplicateEmail),
				Description = string.Format("Email już istnieje", email)
			};
		}

		public override IdentityError DuplicateUserName(string userName) {
			return new IdentityError
			{
				Code = nameof(DuplicateUserName),
				Description = string.Format("Użytkownik już istnieje", userName)
			};
		}

		public override IdentityError InvalidEmail(string email) {
			return new IdentityError
			{
				Code = nameof(InvalidEmail),
				Description = string.Format("Niepoprawny email", email)
			};
		}



		public override IdentityError InvalidUserName(string userName) {
			return new IdentityError
			{
				Code = nameof(InvalidUserName),
				Description = string.Format("niepoprawny email", userName)
			};
		}

		public override IdentityError LoginAlreadyAssociated() {
			return new IdentityError
			{
				Code = nameof(LoginAlreadyAssociated),
				Description = "Login już istnieje"
			};
		}

		public override IdentityError PasswordMismatch() {
			return new IdentityError
			{
				Code = nameof(PasswordMismatch),
				Description = "Hasła niezgodne"
			};
		}

		public override IdentityError PasswordRequiresDigit() {
			return new IdentityError
			{
				Code = nameof(PasswordRequiresDigit),
				Description = "Hasło wymaga użycia cyfry"
			};
		}

		public override IdentityError PasswordRequiresLower() {
			return new IdentityError
			{
				Code = nameof(PasswordRequiresLower),
				Description = "Hasło wymaga małego przynajmniej 1 małej litery"
			};
		}

		public override IdentityError PasswordRequiresNonAlphanumeric() {
			return new IdentityError
			{
				Code = nameof(PasswordRequiresNonAlphanumeric),
				Description = "Hasło wymaga znaku specjalnego"
			};
		}

		public override IdentityError PasswordRequiresUniqueChars(int uniqueChars) {
			return new IdentityError
			{
				Code = nameof(PasswordRequiresUniqueChars),
				Description = string.Format("Hasło wymaga znaku specjalnego", uniqueChars)
			};
		}

		public override IdentityError PasswordRequiresUpper() {
			return new IdentityError
			{
				Code = nameof(PasswordRequiresUpper),
				Description = "Hasło wymaga przynajmniej 1 dużej litery"
			};
		}

		public override IdentityError PasswordTooShort(int length) {
			return new IdentityError
			{
				Code = nameof(PasswordTooShort),
				Description = string.Format("Zbyt krótkie hasło", length)
			};
		}

		public override IdentityError UserAlreadyHasPassword() {
			return new IdentityError
			{
				Code = nameof(UserAlreadyHasPassword),
				Description = "Użytkownik już ma hasło"
			};
		}


		public override IdentityError UserLockoutNotEnabled() {
			return new IdentityError
			{

			};
			}
	}
}
