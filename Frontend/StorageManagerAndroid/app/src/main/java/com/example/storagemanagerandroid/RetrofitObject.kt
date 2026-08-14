package com.example.storagemanagerandroid
import  retrofit2.Retrofit
import retrofit2.converter.gson.GsonConverterFactory
object RetrofitObject {
        private const val BASE_URL = "http://10.0.2.2:5266/"

        val apiInterface: ApiInterface by lazy {
            Retrofit.Builder()
                .baseUrl(BASE_URL)
                .addConverterFactory(GsonConverterFactory.create())
                .build()
                .create(ApiInterface::class.java)
        }
}