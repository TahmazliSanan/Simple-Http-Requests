<div>
  <h1>
    Simple HTTP requests using C#
  </h1>
</div>

<div>
  <p>
    We learned to send some simple HTTP requests to an API. Firstly, we use HttpClient class and pass API URL to GetStringAsync() method. Then as a result response in a JSON format is returned. Then we create class (eg: CatFact) and install Newtonsoft.Json package. We take this response (JSON) and deserialize to CatFact class using DeserializeObject<>() method. Finally we can get any information which we want.
  </p>
</div>
