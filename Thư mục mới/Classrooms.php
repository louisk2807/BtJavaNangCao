<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;
use Illuminate\Support\Facades\DB;

class Classrooms extends Model
{
    use HasFactory;
    protected $table = "classrooms";

    public function index(){
        $classrooms = DB::table('classrooms')->get();
        return $classrooms;
    }

    public function store(){
        DB::table('classrooms')
            ->insert([
                'name' => $this->name,
                'count_student' => $this->count_student
            ]);
    }

    public function edit(){
        $classrooms = DB::table('classrooms')
            ->where('id', $this->id)
            ->get();
        return $classrooms;
    }

    public function updateClassrooms(){
        DB::table('classrooms')
            ->where('id', $this->id)
            ->update([
                'name' => $this->name,
                'count_student' => $this->count_student
            ]);
    }

    public function destroyClassrooms(){
        DB::table('classrooms')
            ->where('id', $this->id)
            ->delete();
    }
}
