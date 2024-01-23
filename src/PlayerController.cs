using Microsoft.AspNetCore.Mvc;
using Library;

namespace Server.Controllers;

[ApiController]
[Route("controller")]

public class PlayerController : ControllerBase {
    [HttpGet("{id}")]
    public Player Get([FromRoute] int id) {
        var player = new Player(); // Not complete yet, need to make a player list and be able to get from that list and manage games 'n stuff
        return player;
    }

    [HttpPost]
    public Player Set([FromQuery] int id) {
        return player;
    }

}