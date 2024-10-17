package com.jtdev.all_study;

import android.content.Intent;
import android.os.Bundle;
import android.widget.Button;
import android.widget.ImageButton;
import android.widget.Toast;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class TeacherOrStudentLogIn extends AppCompatActivity {
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_teacher_or_student_log_in);

        ImageButton  student = findViewById(R.id.student);
        ImageButton  teacher = findViewById(R.id.teacher);
        ImageButton  back = findViewById(R.id.back);

        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });

        teacher.setOnClickListener(v -> {

            Toast.makeText(TeacherOrStudentLogIn.this, "Welcome Teacher!", Toast.LENGTH_SHORT).show();
            Intent intent = new Intent(TeacherOrStudentLogIn.this, SignmeIn.class);
            startActivity(intent);
        });


        student.setOnClickListener(v -> {
            // Logic for Sign In button
            Toast.makeText(TeacherOrStudentLogIn.this, "Welcome Student!", Toast.LENGTH_SHORT).show();
            Intent intent = new Intent(TeacherOrStudentLogIn.this, SignmeIn.class);
            startActivity(intent);
        });

        back.setOnClickListener(v -> {

            Intent intent = new Intent(TeacherOrStudentLogIn.this, Signin_SignUp.class);
            startActivity(intent);
        });
    }
}