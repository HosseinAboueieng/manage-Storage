package com.example.storagemanagerandroid

import kotlin.uuid.ExperimentalUuidApi
import kotlin.uuid.Uuid
data class ProductResponse @OptIn(ExperimentalUuidApi::class) constructor(
    val id:  String,
    val  productName: String,
    val companyName: String,
    val groupName: String? = null
)