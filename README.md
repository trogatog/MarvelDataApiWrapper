MarvelDataApiWrapper
====================

Wrapper class for Marvel's Data API


Usage
====================

Add the following values to your web.config configuration section:

<appSettings>
    <!-- API Keys -->
    <add key="PublicKey" value="" />
    <add key="PrivateKey" value="" />
    <!-- Endpoints -->
    <add key="MarvelApiEndpoint" value="http://gateway.marvel.com" />
    <add key="MarvelApiVersion" value="1" />
  </appSettings>

When instansiating the API, you will need to designate the wrapper class you are expecting to be returned:

IMarvelApi<CharacterDataWrapper> _marvelApi = new MarvelApi<CharaterDataWrapper>();

Api Calls
====================

<strong>DataWrapperBaseChildObject GetAll(MarvelTypes type)</strong>: <br/>Returns the Wrapper Object for the type "type" (i.e. MarvelTypes.Characters)<br/>
<strong>DataWrapperBaseChildObject GetTypeByEntity(ObjectBase entity, MarvelTypes type)</strong>: <br/>Returns the Wrapper Object for the type "type" related to the object "entity"
<br/>	For example, to get all Comics by Character, Pass the Character object as the first parameter into GetTypeByEntity, and MarvelTypes.Comics as the second parameter <em>(note: the entity object only needs the Marvel ID from the API)</em>:

		var character = new Character{MarvelId = 1009521}; //Hank Pym
		ComicDataWrapper data = _marvelApi.GetTypeByEntity(character, MarvelTypes.Comics);

<strong>DataWrapperBaseChildObject GetTypeByUrl(string url)</strong>: <br/>Returns the resulting data wrapper from a given url