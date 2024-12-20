using Microsoft.AspNetCore.Identity;
using System;

namespace GreenIdentity.Models;

public class GreenUser<TKey> : IdentityUser<TKey> where TKey : IEquatable<TKey>
{
}

public class GreenRole<TKey> : IdentityRole<TKey> where TKey : IEquatable<TKey>
{ }

public class GreenUserRole<TKey> : IdentityUserRole<TKey> where TKey : IEquatable<TKey>
{ }

public class GreenUserClaim<TKey> : IdentityUserClaim<TKey> where TKey : IEquatable<TKey>
{ }

public