<?php

namespace App\Http\Controllers;

use App\Models\Classrooms;
use App\Models\Students;
use App\Http\Requests\StoreStudentsRequest;
use App\Http\Requests\UpdateStudentsRequest;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Redirect;

class StudentsController extends Controller
{
    /**
     * Display a listing of the resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function index()
    {
        $obj = new Students();
        $students = $obj->index();
        return view('students.index', [
            'students' => $students
        ]);
    }

    /**
     * Show the form for creating a new resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function create()
    {
        $objClass = new Classrooms();
        $classrooms = $objClass->index();
        return view('students.create', [
            'classrooms' => $classrooms
        ]);
    }

    /**
     * Store a newly created resource in storage.
     *
     * @param  \App\Http\Requests\StoreStudentsRequest  $request
     * @return \Illuminate\Http\Response
     */
    public function store(StoreStudentsRequest $request)
    {
        $obj = new Students();
        $obj->name = $request->name;
        $obj->address = $request->address;
        $obj->phone = $request->phone;
        $obj->email = $request->email;
        $obj->classroom_id  = $request->classroom_id;
        $obj->storeStudent();

        return Redirect::route('student.index');
    }

    /**
     * Display the specified resource.
     *
     * @param  \App\Models\Students  $students
     * @return \Illuminate\Http\Response
     */
    public function show(Students $students)
    {
        //
    }

    /**
     * Show the form for editing the specified resource.
     *
     * @param  \App\Models\Students  $students
     * @return \Illuminate\Http\Response
     */
    public function edit(Students $students, Request $request)
    {
        $objClassrooms = new Classrooms();
        $classrooms = $objClassrooms->index();
        $objStudent = new Students();
        $objStudent->id_student = $request->id;
        $students = $objStudent->edit();
        return view('students.edit', [
            'classrooms' => $classrooms,
            'students' => $students,
            'id_student' => $objStudent->id_student
        ]);
    }

    /**
     * Update the specified resource in storage.
     *
     * @param  \App\Http\Requests\UpdateStudentsRequest  $request
     * @param  \App\Models\Students  $students
     * @return \Illuminate\Http\Response
     */
    public function update(UpdateStudentsRequest $request, Students $students)
    {
        $obj = new Students();
        $obj->id_student = $request->id;
        $obj->name = $request->name;
        $obj->address = $request->address;
        $obj->phone = $request->phone;
        $obj->email = $request->email;
        $obj->classroom_id = $request->classroom_id;
        $obj->updateStudent();
        return Redirect::route('student.index');
    }

    /**
     * Remove the specified resource from storage.
     *
     * @param  \App\Models\Students  $students
     * @return \Illuminate\Http\Response
     */
    public function destroy(Students $students, Request $request)
    {
        $obj = new Students();
        $obj->id_student = $request->id;
        $obj->destroyStudents();
        return Redirect::route('student.index');
    }
}
