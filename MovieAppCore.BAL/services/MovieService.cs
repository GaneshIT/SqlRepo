using System;
using System.Collections.Generic;
using System.Text;
using MovieAppCore.DAL.Repository;
using MovieAppCore.Entity.Models;

namespace MovieAppCore.BAL.services
{
    public class MovieService
    {
        IMovieRepository _movieRepository;
        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        //add movie
        public void AddMoive(Movie movie)
        {
            _movieRepository.AddMovie(movie);
        }
        //update movie
        public void UpdateMoive(Movie movie)
        {
            _movieRepository.UpdateMovie(movie);
        }
        //delete movie
        public void DeleteMovie(int movieId)
        {
            _movieRepository.DeleteMovie(movieId);
        }
        //Get GetMovieByid
        public void GetMovieByid(int movieId)
        {
            _movieRepository.GetMovieById(movieId);
        }
        //Get GetMovies
        public IEnumerable<Movie> GetMovies()
        {
           return _movieRepository.GetMovies();
        }

        public object GetAllMovies()
        {
            object o = "";
            return o;
        }
        public object GetAllMoviesByLocation()
        {
            object s = "";
            return s;
        }
        public object GetAllMoviesByState()
        {
            object o = "";
            return o;
        }
    }
}
