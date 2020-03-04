﻿using System.Threading.Tasks;
using Slack.Webhooks.Chat;
using Slack.Webhooks.Messages;

namespace Slack.Webhooks.Interfaces
{
    public interface IChatClient
    {
        DeleteResponse Delete(DeleteRequest request);
        Task<DeleteResponse> DeleteAsync(DeleteRequest request);

        PermalinkResponse Permalink(PermalinkRequest request);
        Task<PermalinkResponse> PermalinkAsync(PermalinkRequest request);
        PostMessageResponse PostMessage(PostMessage message);
        Task<PostMessageResponse> PostMessageAsync(PostMessage message);
    }
}