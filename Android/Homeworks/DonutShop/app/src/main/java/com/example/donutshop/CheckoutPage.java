package com.example.donutshop;

import android.app.DatePickerDialog;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

import java.text.DecimalFormat;
import java.util.Calendar;

public class CheckoutPage extends AppCompatActivity {

    private TextView DateBox;
    private Calendar selectedDate;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_checkout_page);

        Button CancelDealBtn = findViewById(R.id.CancelDealBtn);
        Button ConfirmDealBtn = findViewById(R.id.ConfirmDealBtn);
        Button DatePickerBtn = findViewById(R.id.DatePickerBtn);
        EditText ForBox = findViewById(R.id.Forbox);
        DateBox = findViewById(R.id.DateBox);
        TextView TotalPriceBox = findViewById(R.id.TotalPriceBox);
        TextView OrderDetails = findViewById(R.id.OrderDetails);

        Intent intent = getIntent();
        String sufganiaSelection = intent.getStringExtra("sufgania_selection");
        String donutSelection = intent.getStringExtra("donut_selection");
        double sufganiaQuantity = intent.getDoubleExtra("sufganiya_quantity", 0.0);
        double donutQuantity = intent.getDoubleExtra("donut_quantity", 0.0);
        boolean sufganiyaJamSwitch = intent.getBooleanExtra("sufganiya_jam_switch", false);
        boolean donutChocolateType = intent.getBooleanExtra("donut_chocolate_type", false);
        double sufganiyaFinalPrice = intent.getDoubleExtra("sufganiya_final_price", 0.0);
        double donutFinalPrice = intent.getDoubleExtra("donut_final_price", 0.0);

        // Build order details string
        StringBuilder orderDetails = new StringBuilder();
        
        // Add Sufganiya details
        if (sufganiaQuantity > 0) {
            orderDetails.append("Sufganiya: ").append(sufganiaQuantity);
            if (sufganiyaJamSwitch) {
                orderDetails.append(" (With Jam)");
            }
            orderDetails.append(" - ").append(formatPrice(sufganiyaFinalPrice)).append("\n");
        }
        
        // Add Donut details
        if (donutQuantity > 0) {
            orderDetails.append("Donut: ").append(donutQuantity);
            if (donutChocolateType) {
                orderDetails.append(" (With Chocolate Type)");
            }
            orderDetails.append(" - ").append(formatPrice(donutFinalPrice));
        }
        
        OrderDetails.setText(orderDetails.toString());

        // Calculate and display total
        double total = sufganiyaFinalPrice + donutFinalPrice;
        TotalPriceBox.setText(formatPrice(total));

        // Initialize date picker
        selectedDate = Calendar.getInstance();
        DatePickerBtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                int year = selectedDate.get(Calendar.YEAR);
                int month = selectedDate.get(Calendar.MONTH);
                int day = selectedDate.get(Calendar.DAY_OF_MONTH);

                DatePickerDialog datePickerDialog = new DatePickerDialog(
                        CheckoutPage.this,
                        (view, selectedYear, selectedMonth, selectedDay) -> {
                            selectedDate.set(selectedYear, selectedMonth, selectedDay);
                            String dateStr = String.format("%02d/%02d/%04d", selectedDay, selectedMonth + 1, selectedYear);
                            DateBox.setText(dateStr);
                            DateBox.setVisibility(View.VISIBLE);
                            DatePickerBtn.setVisibility(View.GONE);
                        },
                        year, month, day
                );
                datePickerDialog.show();
            }
        });

        // Cancel button - go back to main activity
        CancelDealBtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                finish();
            }
        });

        // Confirm button - complete the order
        ConfirmDealBtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                String customerName = ForBox.getText().toString().trim();
                String date = DateBox.getText().toString();
                
                if (customerName.isEmpty()) {
                    Toast.makeText(CheckoutPage.this, "Please enter customer name", Toast.LENGTH_SHORT).show();
                    return;
                }
                
                if (date.isEmpty()) {
                    Toast.makeText(CheckoutPage.this, "Please select a date", Toast.LENGTH_SHORT).show();
                    return;
                }
                
                // Order confirmed
                String message = "Order confirmed for " + customerName + "!\nTotal: " + formatPrice(total);
                Toast.makeText(CheckoutPage.this, message, Toast.LENGTH_LONG).show();
                
                // Optionally go back to main activity after a delay
                new android.os.Handler().postDelayed(new Runnable() {
                    @Override
                    public void run() {
                        finish();
                    }
                }, 2000);
            }
        });

        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });
    }

    private String formatPrice(double price) {
        DecimalFormat df = new DecimalFormat("#0.00");
        return df.format(price) + " NIS";
    }
}