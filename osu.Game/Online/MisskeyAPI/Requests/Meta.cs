// Copyright (c) ppy Pty Ltd <contact@ppy.sh>, sim1222 <kokt@sim1222.com>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System.Net.Http;
using osu.Framework.IO.Network;

namespace osu.Game.Online.MisskeyAPI.Requests
{
    public class Meta : APIRequest<MisskeyAPI.Requests.Responses.Meta>
    {
        public string instanceUrl { get; }

        public Meta(string instanceUrl)
        {
            this.instanceUrl = instanceUrl;
        }

        protected override WebRequest CreateWebRequest()
        {
            var req = base.CreateWebRequest();
            req.Method = HttpMethod.Post;
            return req;
        }

        public string APIEndpointUrl => $"https://{instanceUrl}";
        protected override string Target => @"meta";
    }
}
