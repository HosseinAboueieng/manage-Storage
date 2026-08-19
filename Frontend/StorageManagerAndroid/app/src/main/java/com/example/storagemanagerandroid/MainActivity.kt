package com.example.storagemanagerandroid

import android.R
import android.os.Bundle
import androidx.activity.ComponentActivity
import androidx.activity.compose.setContent
import androidx.activity.enableEdgeToEdge
import androidx.compose.foundation.background
import androidx.compose.foundation.border
import androidx.compose.foundation.layout.Arrangement
import androidx.compose.foundation.layout.Column
import androidx.compose.foundation.layout.Row
import androidx.compose.foundation.layout.fillMaxSize
import androidx.compose.foundation.layout.fillMaxWidth
import androidx.compose.foundation.layout.padding
import androidx.compose.foundation.layout.width
import androidx.compose.foundation.shape.RoundedCornerShape
import androidx.compose.material3.Button
import androidx.compose.material3.ButtonDefaults
import androidx.compose.material3.Scaffold
import androidx.compose.material3.Text
import androidx.compose.material3.TextField
import androidx.compose.runtime.Composable
import androidx.compose.runtime.mutableStateOf
import androidx.compose.runtime.getValue
import androidx.compose.runtime.remember
import androidx.compose.runtime.setValue
import androidx.compose.runtime.rememberCoroutineScope
import androidx.compose.runtime.saveable.rememberSaveable
import androidx.compose.ui.Alignment
import androidx.compose.ui.Modifier
import androidx.compose.ui.graphics.Color
import androidx.compose.ui.graphics.Outline
import androidx.compose.ui.tooling.preview.Preview
import androidx.compose.ui.unit.dp
import androidx.compose.ui.unit.sp
import androidx.navigation.NavController
import androidx.navigation.compose.NavHost
import androidx.navigation.compose.rememberNavController
import com.example.storagemanagerandroid.ui.theme.StorageManagerAndroidTheme
import kotlinx.coroutines.launch
class MainActivity : ComponentActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        setContent {
            val navController= rememberNavController()
            NavHost(
                navController = navController,
                startDestination = "MenuActivity"
            )
            {

            }
            StorageManagerAndroidTheme {
                Scaffold(modifier = Modifier.fillMaxSize()) { innerPadding ->
                    Column(modifier = Modifier.padding(innerPadding)) {
                        Column(modifier = Modifier.fillMaxWidth().padding(top = 45.dp),
                            horizontalAlignment = Alignment.CenterHorizontally) {
                            searchAproductByName()
                        }
                    }
                }
            }
        }
    }
}

@Composable
fun Greeting(name: String, modifier: Modifier = Modifier) {
    Text(
        text = "Hello $name!",
        modifier = modifier
    )
}

@Composable
fun searchAproductByName() {
    val scope = rememberCoroutineScope()
    var productName by remember { mutableStateOf("") }
    var textProduct by rememberSaveable { mutableStateOf("کالایی پیدا نشد") }
    var textCompany by remember { mutableStateOf("کمپانی پیدا نشد") }
    var textGroup by remember { mutableStateOf("نوع محصول پیدا نشد") }
    Column(
        modifier =
            Modifier.background(Color.White).width(290.dp)
    ) {
        Row(modifier = Modifier.fillMaxWidth(),
            horizontalArrangement = Arrangement.SpaceBetween) {
            Text(
            text = textProduct,
            color = Color.Black,
            fontSize = 20.sp
            )
            Text(
                text = ": نام محصول",
                color = Color.LightGray,
                fontSize = 20.sp,
            )
        }
        Row(modifier = Modifier.fillMaxWidth(),
            horizontalArrangement = Arrangement.SpaceBetween)
        {
            Text(
                text =textCompany,
                color = Color.Black,
                fontSize = 20.sp
            )
            Text(
                text = ": نام شرکت تولید کننده",
                color = Color.LightGray,
                fontSize = 20.sp,
            )
        }
        Row(modifier = Modifier.fillMaxWidth(),
            horizontalArrangement = Arrangement.SpaceBetween)
        {
            Text(
                text =textGroup,
                color = Color.Black,
                fontSize = 20.sp
            )
            Text(
                text = ":نوع محصول ",
                color = Color.LightGray,
                fontSize = 20.sp,
            )
        }

        TextField(
            value = productName,
            onValueChange = { newtext -> productName = newtext },
            label = { Text(" نام محصول خود را وارد کنیم", Modifier.padding(start =70.dp)) },
            shape = RoundedCornerShape(12.dp)
        )
        Button(
            onClick = {
                scope.launch {
                    try {
                    getProductbyName(productName) { product ->

                            textProduct = product.productName
                            if (product.groupName.isNullOrEmpty())
                                textGroup = "no difine"
                            else
                                textGroup = product.groupName
                            textCompany = product.companyName
                    } }catch (e: Exception)
                    {
                        textProduct="not found"
                        textCompany="not found"
                        textGroup="not found"
                    }
                }
            },
            modifier = Modifier.width(280.dp).padding(top = 8.dp, start = 3.dp, end = 3.dp),
            colors = ButtonDefaults.buttonColors(
                containerColor = Color.Black,
                contentColor = Color.White
            ), shape = RoundedCornerShape(12.dp)
        )
        {
            Text("جستجو")
        }
    }
}
suspend fun getProductbyName(name: String, onResult: (ProductResponse) -> Unit){

    try {
        val result= RetrofitObject.apiInterface.getAProductByName(name);
        onResult(result)
    }catch (e: Exception) {
        throw e
    }
}

@Preview(showBackground = true)
@Composable
fun GreetingPreview() {
    StorageManagerAndroidTheme {
        Greeting("Android")
    }
}
@Preview(showBackground = true)
@Composable
fun show(){
    StorageManagerAndroidTheme {
        searchAproductByName()
    }
}