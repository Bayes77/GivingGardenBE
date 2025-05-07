
<h1 align="center" style="font-weight: bold;">🌱 Giving Gardens 💚</h1>

<p align="center">
<a href="#tech">Technologies</a>
<a href="#started">Getting Started</a>
<a href="#routes">API Endpoints</a>
<a href="#colab">Collaborators</a>
<a href="#contribute">Contribute</a> 
</p>


<p align="center">Giving Garden is a heartfelt platform where generosity takes root and compassion blossoms. Designed to help individuals, families, small businesses, and nonprofits raise funds for meaningful causes.
Supporters can easily discover causes that speak to them, donate directly, and watch the impact of their contributions bloom. At Giving Garden, every donation is a seed of kindness—and together, we’re cultivating a better world, one cause at a time.
</p>


<p align="center">
<a href="https://github.com/Bayes77/GivingGardenBE">📱 Visit this Project</a>
</p>

<h2 id="technologies">💻 Technologies</h2>

- C#              
- .Net                      
- React
- Pg Admin 
- Postman
- Swagger
- Visual Studio
- Visual Studio Code

<h2 id="started">🚀 Getting started</h2>

- Click the "Visit This Project" Link above
- In the green "Code" box, click the down arrow
- Select "HTTPS"
- Copy the link to your clipboard
- In your terminal type:
- git clone "https address" without quotes, press enter
- type: cd SimplyBooksBEnd, press enter
- type: code . , press enter
- You should be able to view the project
- In your project directory run:
- dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL --version 8.0, press enter
- dotnet add package Microsoft.EntityFrameworkCore.Design --version 8.0,press enter
- dotnet user-secrets init, press enter
- dotnet user-secrets set "GivingGardenBEConnectionString" "Host=localhost;Port=5432;Username=postgres;Password=<your postgres password>;Database=GivingGardenBE",press enter
- dotnet ef database update, press enter
- To Install Entity Framework Tools:
- dotnet tool install --global dotnet-ef, press enter


<h3>Prerequisites</h3>

Here you list all prerequisites necessary for running the project. 

- [Git Hub](https://github.com/)
- [.NET SDK](https://dotnet.microsoft.com/en-us/download)
- [Visual Studio](https://visualstudio.microsoft.com/)
- or [Visual Studio Code](https://code.visualstudio.com/)
- [PostgreSQL](https://www.postgresql.org/download/)

<h3>Cloning</h3>

How to clone your project

```bash
https://github.com/Bayes77/GivingGardenBE
```

<h3>Config .env variables</h2>

Use the `.env.example` as reference to create your configuration file `.env` with your AWS Credentials

```yaml
NEXT_PUBLIC_FIREBASE_API_KEY=""
NEXT_PUBLIC_FIREBASE_AUTH_DOMAIN=""
NEXT_PUBLIC_FIREBASE_DATABASE_URL=""
NEXT_PUBLIC_FIREBASE_PROJECT_ID=""
NEXT_PUBLIC_FIREBASE_STORAGE_BUCKET=""
NEXT_PUBLIC_FIREBASE_APP_ID=""
```

<h3>Starting</h3>

How to start your project

```bash
cd GivingGardenBE
dotnet watch run
```

<h2 id="routes">📍 API Endpoints</h2>

Here you can list the main routes of your API, and what are their expected request bodies. For complete API calls and documentation:
[Postman documentation]([https://m11111-1406.postman.co/workspace/My-Workspace~6ab94679-970e-47be-8f5f-27b01e48e7bc/request/36650801-59c345e1-af89-40ef-9d85-785d43f4d6c8?action=share&creator=36650801&ctx=documentation](https://documenter.getpostman.com/view/36650801/2sB2j7d9eq)
​
| route               | description                                          
|----------------------|-----------------------------------------------------
| <kbd>GET /api/organization</kbd>     | retrieves organization info see [response details](#get-auth-detail)
| <kbd>PUT /api/user/{id}</kbd>     | retrieves user info for updating see [response details](#put-auth-detail)
| <kbd>POST /api/subscription</kbd>     | authenticate subscription into the api see [request details](#post-auth-detail)
| <kbd>GET /paymenttypes</kbd>     | retrieves payment type info see [response details](#getP-auth-detail)

<h3 id="get-auth-detail">GET /organization</h3>

**RESPONSE**
```json
    {
        "id": 103,
        "userId": 3,
        "title": "Wings of Warmth",
        "email": "WOWtest.gmail.com",
        "image": "test.png",
        "description": "Knits invisible scarves for people experiencing metaphorical winters.",
        "users": [],
        "subscriptions": []
    }
```
<h3 id="put-auth-detail">PUT /user</h3>

**REQUEST**
```json
  {
    "id": 10,
    "name": "Patrick's Rock Blog",
    "email": "patrick@underarock.net",
    "image": "patrick-thinking-hard.png"
  }
```

<h3 id="post-auth-detail">POST /subscription</h3>

**REQUEST**
```json
{
    "id": 11,
    "userId": 4,
    "organizationId": 101,
    "subscribed_at": "2025-04-19T15:04:55.257Z",
    "paymentType": "mastercard",
    "paymentAmount": 35
}
```
<h3 id="getP-auth-detail">GET /payment types</h3>

**RESPONSE**
```json
    {
        "id": 2,
        "paymentTypeName": "PayPal"
    }
```

<h2 id="colab">🤝 Collaborators</h2>

<p>Special thank you for all people that contributed for this project.</p>
<table>
<tr>

<td align="center">
<a href="https://github.com/Bayes77">
<img src="https://avatars.githubusercontent.com/u/173638175?v=4" width="100px;" alt="Matthew Bayes Profile Picture"/><br>
<sub>
<b>Matthew Bayes</b>
</sub>
</a>
</td>

<td align="center">
<a href="https://github.com/DTrejo98">
<img src="https://avatars.githubusercontent.com/u/174376521?v=4" width="100px;" alt="David Trejo Profile Picture"/><br>
<sub>
<b>David Trejo</b>
</sub>
</a>
</td>

<td align="center">
<a href="https://github.com/GraceRenewed">
<img src="https://avatars.githubusercontent.com/u/171828567?v=4" width="100px;" alt="Christina Vieau Profile Picture"/><br>
<sub>
<b>Christina Vieau</b>
</sub>
</a>
</td>

</tr>
</table>

<h2 id="contribute">📫 Contribute</h2>

Here you will explain how other developers can contribute to your project. For example, explaining how can create their branches, which patterns to follow and how to open an pull request

1. `git clone https://github.com/Bayes77/GivingGardenBE`
2. `git checkout -b feature/NAME`
3. Follow commit patterns
4. Open a Pull Request explaining the problem solved or feature made, if exists, append screenshot of visual modifications and wait for the review!

<h3>Documentations that might help</h3>

[📝 How to create a Pull Request](https://www.atlassian.com/br/git/tutorials/making-a-pull-request)

[💾 Commit pattern](https://gist.github.com/joshbuchea/6f47e86d2510bce28f8e7f42ae84c716)
