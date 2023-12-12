using Microsoft.AspNetCore.Mvc;

namespace MiSpotifyClon.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SpotifyController : ControllerBase
    {
        private readonly String clientId = "42e9272ed3554ab49eb842459cb2c266";
        private readonly String clientSecret = "607078f4191a485b9ebee0f01d0db43a";
        private readonly String redirectUri = "http://192.168.1.137/playlist.html";
        private readonly String scope = "user-read-private user-read-email";
        private readonly String authUrl = "https://accounts.spotify.com/authorize";

        public void Prueba()
        {

        }
    }
}
