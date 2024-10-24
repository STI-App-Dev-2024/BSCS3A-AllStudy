package com.jtdev.all_study;

import android.annotation.SuppressLint;
import android.content.Intent;
import android.os.Bundle;
import android.widget.ImageButton;
import android.widget.Toast;

import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class TeacherOrStudentSignIn extends AppCompatActivity {

    @SuppressLint("MissingInflatedId")
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_04teacher_or_student_sign_in);

        // Initialize buttons
        ImageButton student = findViewById(R.id.student);
        ImageButton teacher = findViewById(R.id.teacher);
        ImageButton navback = findViewById(R.id.navback);

        // Handle system window insets for proper layout
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });

        // Teacher button click listener
        teacher.setOnClickListener(v -> {
            Toast.makeText(TeacherOrStudentSignIn.this, "Welcome Teacher!", Toast.LENGTH_SHORT).show();
            Intent intent = new Intent(TeacherOrStudentSignIn.this, Teacher_SignUp.class);
            startActivity(intent);
        });

        // Student button click listener
        student.setOnClickListener(v -> {
            Toast.makeText(TeacherOrStudentSignIn.this, "Welcome Student!", Toast.LENGTH_SHORT).show();
            Intent intent = new Intent(TeacherOrStudentSignIn.this, Student_SignUp.class);
            startActivity(intent);
        });

        // Back button click listener
        navback.setOnClickListener(v -> {
            Intent intent = new Intent(TeacherOrStudentSignIn.this, Signin_SignUp.class);
            startActivity(intent);
        });
    }
}
