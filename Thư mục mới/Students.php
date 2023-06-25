<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;
use Illuminate\Support\Facades\DB;

class Students extends Model
{
    use HasFactory;
    protected $table = "students";

    public function index(){
        $students = DB::table('students')
            ->join('classrooms', 'students.classroom_id', '=', 'classrooms.id')
            ->select('students.*',
                'classrooms.name AS class_name')
            ->get();
        return $students;
    }

    public function storeStudent(){
        DB::table('students')
            ->insert([
                'name' => $this->name,
                'address' => $this->address,
                'phone' => $this->phone,
                'email' => $this->email,
                'classroom_id' => $this->classroom_id,
            ]);
    }

    public function edit(){
        $students = DB::table('students')
            ->where('id_student', $this->id_student)
            ->get();

        return $students;
    }

    public function updateStudent(){
        DB::table('students')
            ->where('id_student', $this->id_student)
            ->update([
                'name' => $this->name,
                'address' => $this->address,
                'phone' => $this->phone,
                'email' => $this->email,
                'classroom_id' => $this->classroom_id
            ]);
    }

    public function destroyStudents(){
        DB::table('students')
            ->where('id_student', $this->id_student)
            ->delete();
    }
}
