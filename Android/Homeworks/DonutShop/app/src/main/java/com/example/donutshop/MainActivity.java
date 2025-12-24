package com.example.donutshop;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Switch;
import android.widget.ToggleButton;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class MainActivity extends AppCompatActivity {

    Double SufganiyaPrice = 1.5;
    Double DonutPrice = 3.5;
    Double SufganiyaFinalPrice = 0.0;
    Double DonutFinalPrice = 0.0;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);

        EditText SufganiaSelectionBox = findViewById(R.id.SufganiaSelectionBox);
        EditText DonutSelectionBox = findViewById(R.id.DonutSelectionBox);
        Switch SufganiyaJamSwitch = findViewById(R.id.SufganiyaJamSwitch);
        ToggleButton DonutChocolateTypeToggle = findViewById(R.id.DonutChocolateTypeToggle);
        Button CheckoutButton = findViewById(R.id.CheckoutButton);

        CheckoutButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                String sufganiaSelection = SufganiaSelectionBox.getText().toString();
                String donutSelection = DonutSelectionBox.getText().toString();
                boolean sufganiyaJamSwitch = SufganiyaJamSwitch.isChecked();
                boolean donutChocolateType = DonutChocolateTypeToggle.isChecked();

                // Handle empty input - default to 0 if empty
                double sufganiaQuantity = 0.0;
                double donutQuantity = 0.0;
                
                if (!sufganiaSelection.isEmpty()) {
                    try {
                        sufganiaQuantity = Double.parseDouble(sufganiaSelection);
                    } catch (NumberFormatException e) {
                        sufganiaQuantity = 0.0;
                    }
                }
                if (!donutSelection.isEmpty()) {
                    try {
                        donutQuantity = Double.parseDouble(donutSelection);
                    } catch (NumberFormatException e) {
                        donutQuantity = 0.0;
                    }
                }

                // Calculate Sufganiya price
                if (sufganiyaJamSwitch) {
                    SufganiyaFinalPrice = (SufganiyaPrice + 1) * sufganiaQuantity;
                } else {
                    SufganiyaFinalPrice = SufganiyaPrice * sufganiaQuantity;
                }

                // Calculate Donut price (add 0.7 if chocolate type is selected)
                if (donutChocolateType) {
                    DonutFinalPrice = (DonutPrice + 0.7) * donutQuantity;
                } else {
                    DonutFinalPrice = DonutPrice * donutQuantity;
                }

                Intent intent = new Intent(MainActivity.this, CheckoutPage.class);
                intent.putExtra("sufgania_selection", sufganiaSelection);
                intent.putExtra("donut_selection", donutSelection);
                intent.putExtra("sufganiya_quantity", sufganiaQuantity);
                intent.putExtra("donut_quantity", donutQuantity);
                intent.putExtra("sufganiya_jam_switch", sufganiyaJamSwitch);
                intent.putExtra("donut_chocolate_type", donutChocolateType);
                intent.putExtra("sufganiya_final_price", SufganiyaFinalPrice);
                intent.putExtra("donut_final_price", DonutFinalPrice);
                startActivity(intent);
            }
        });

        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });
    }
}
