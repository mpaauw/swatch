using swatch.Core.Models;

namespace swatch.Core.Data
{
    public interface ISwatchService
    {
        /// <summary>
        /// Puts a supplied object into a specified file.
        /// If no record key is supplied, one is randomly generated, indicating a create operation rather than an update.
        /// </summary>
        /// <param name="id">Id of file to use in storage.</param>
        /// <param name="payload">Object to store.</param>
        /// <param name="key">Optional key of object to store.</param>
        /// <returns>Result object containing the key of the newly-set record.</returns>
        Result<string> Set(string id, object payload, string key = null);

        /// <summary>
        /// Retrieves a particular object from a specified file.
        /// </summary>
        /// <param name="id">Id of file to use in retrieval.</param>
        /// <param name="key">Key of object to retrieve.</param>
        /// <returns>Result object containing the underlying object retrieved.</returns>
        Result<object> Get(string id, string key);

        /// <summary>
        /// Deletes a given object from a specified file.
        /// </summary>
        /// <param name="id">Id of file to use in deletion.</param>
        /// <param name="key">Key of object to delete.</param>
        /// <returns>Result object containing the key of the underlying object deleted.</returns>
        Result<string> Remove(string id, string key);

        /// <summary>
        /// Creates a new file.
        /// </summary>
        /// <returns>Result object containing the id of the newly-created file.</returns>
        Result<string> New();

        /// <summary>
        /// Deletes a file, given it's id.
        /// </summary>
        /// <param name="id">Id of the file to delete.</param>
        /// <returns>Id of the newly-deleted file.</returns>
        Result<string> Kill(string id);
    }
}
