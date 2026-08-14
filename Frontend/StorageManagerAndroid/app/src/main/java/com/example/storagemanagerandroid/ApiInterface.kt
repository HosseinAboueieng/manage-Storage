package com.example.storagemanagerandroid

import android.R
import android.icu.text.StringSearch
import retrofit2.http.GET
import retrofit2.http.Path
import retrofit2.http.Query

interface ApiInterface {
    @GET("api/products/{id}")
    suspend fun getAProduct(
        @Path("id") productId: String
    ): ProductResponse
    @GET("api/products/findbyname")
    suspend fun  getAProductByName(
        @Query("search") search: String
    ): ProductResponse
}