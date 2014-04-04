﻿using System.Collections.Generic;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNet.Identity
{
    /// <summary>
    ///     Stores user specific claims
    /// </summary>
    /// <typeparam name="TUser"></typeparam>
    public interface IUserClaimStore<TUser> : IUserStore<TUser> where TUser : class
    {
        /// <summary>
        ///     Returns the claims for the user with the issuer set
        /// </summary>
        /// <param name="user"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<IList<Claim>> GetClaims(TUser user, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        ///     Add a new user claim
        /// </summary>
        /// <param name="user"></param>
        /// <param name="claim"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task AddClaim(TUser user, Claim claim, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        ///     Remove a user claim
        /// </summary>
        /// <param name="user"></param>
        /// <param name="claim"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task RemoveClaim(TUser user, Claim claim, CancellationToken cancellationToken = default(CancellationToken));
    }
}